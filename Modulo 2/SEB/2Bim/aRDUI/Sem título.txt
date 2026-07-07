/*
  Testando rotação de busca, sensor parado por enquanto.
*/
#include <Servo.h>

const int TRIG_PIN = 9;
const int ECHO_PIN = 10;
const int SERVO_PIN = 6;

const int DIST_LIMITE_CM = 60;
const int ANGULO_REPOUSO = 0;
const int ANGULO_ALERTA = 90;

const int VELOCIDADE_SERVO = 20; // ms entre passos (menor = mais rápido)
const int INTERVALO_SENSOR = 100; // ms entre leituras

Servo servoEixoX;

// Controle de tempo
unsigned long tempoAnteriorSensor = 0;
unsigned long tempoAnteriorServo = 0;

// Controle de estado
bool objetoPresente = false;
bool objetoAnterior = false;

// Controle do servo
int posAtual = 0;
int posAlvo = 0;

void setup() {
  Serial.begin(9600);

  servoEixoX.attach(SERVO_PIN);

  pinMode(TRIG_PIN, OUTPUT);
  pinMode(ECHO_PIN, INPUT);

  posAtual = ANGULO_REPOUSO;
  posAlvo = ANGULO_REPOUSO;
  servoEixoX.write(posAtual);

  Serial.println("===== Radar de busca iniciado ======");
}

void loop() {
  unsigned long agora = millis();

  // Leitura do sensor sem travar
  if (agora - tempoAnteriorSensor >= INTERVALO_SENSOR) {
    tempoAnteriorSensor = agora;

    long distancia = medirDistancia();

    if (distancia > 0 && distancia <= DIST_LIMITE_CM) {
      objetoPresente = true;
    } else {
      objetoPresente = false;
    }

    if (objetoPresente && !objetoAnterior) {
      Serial.print("OBJETO DETECTADO a ");
      Serial.print(distancia);
      Serial.println(" cm");
      posAlvo = ANGULO_ALERTA;
    }

    if (!objetoPresente && objetoAnterior) {
      Serial.println("Objeto saiu -> servo voltando");
      posAlvo = ANGULO_REPOUSO;
    }

    objetoAnterior = objetoPresente;

    Serial.print("Distancia: ");
    if (distancia == -1) {
      Serial.println("sem eco");
    } else {
      Serial.print(distancia);
      Serial.println(" cm");
    }
  }

  // Movimento suave do servo sem travar
  if (agora - tempoAnteriorServo >= VELOCIDADE_SERVO) {
    tempoAnteriorServo = agora;

    if (posAtual < posAlvo) {
      posAtual++;
      servoEixoX.write(posAtual);
    } 
    else if (posAtual > posAlvo) {
      posAtual--;
      servoEixoX.write(posAtual);
    }
  }
}

long medirDistancia() {
  digitalWrite(TRIG_PIN, LOW);
  delayMicroseconds(2);

  digitalWrite(TRIG_PIN, HIGH);
  delayMicroseconds(10);
  digitalWrite(TRIG_PIN, LOW);

  long duracao = pulseIn(ECHO_PIN, HIGH, 30000);

  if (duracao == 0) return -1;

  return duracao / 58;
}