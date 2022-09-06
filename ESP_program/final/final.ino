
#include <ESP8266WiFi.h>
#include <ESP8266WebServer.h>
#include <ESP8266mDNS.h>
#include <WiFiManager.h>

const int output5 = 5;
const int output4 = 4;

int comindex = 0;
int command[3] = {0,0,0};
int incomingByte;

bool WifiSetupSuccessful = false;

ESP8266WebServer server(80);

WiFiManager wifiManager;

void handleRoot() {

server.send(200, "text/plain", "alive");

}

void Port4_ON() {
digitalWrite(output4, HIGH);
server.send(200, "text/plain", "4/on");

}

void Port4_OFF() {
digitalWrite(output4, LOW);
server.send(200, "text/plain", "4/off");

}

void Port5_ON() {
digitalWrite(output5, HIGH);
server.send(200, "text/plain", "5/on");

}

void Port5_OFF() {
digitalWrite(output5, LOW);
server.send(200, "text/plain", "5/off");

}

void setup(){
 // Initialize the output variables as outputs

//pinMode(2, OUTPUT);
//digitalWrite(2, LOW);
 
  pinMode(output5, OUTPUT);
  pinMode(output4, OUTPUT);
  pinMode(0, OUTPUT);
  pinMode(15, OUTPUT);
  pinMode(13, OUTPUT);
  pinMode(12, OUTPUT);
  pinMode(14, OUTPUT);
  pinMode(16, OUTPUT);
  // Set outputs to LOW
  digitalWrite(0, LOW);
  digitalWrite(15, LOW);
  digitalWrite(13, LOW);
  digitalWrite(12, LOW);
  digitalWrite(14, LOW);
  digitalWrite(16, LOW);
  digitalWrite(output5, LOW);
  digitalWrite(output4, LOW);

  WiFi.mode(WIFI_STA); // explicitly set mode, esp defaults to STA+AP

  Serial.begin(9600);

  wifiManager.setConfigPortalBlocking(false);
  wifiManager.setConfigPortalTimeout(600);

  if(wifiManager.autoConnect("Lampa_vezerlo_konfig", "ajrdp70660"))
  {
    WifiSetupSuccessful = true;
    if (!MDNS.begin("esp8266")) {
      //Serial.println("Error setting up MDNS responder!");
      while (1) {
        delay(1000);
      }
    }

    server.on("/", handleRoot);  //Associate handler function to path
    server.on("/4/on", Port4_ON);  //Associate handler function to path
    server.on("/4/off", Port4_OFF);  //Associate handler function to path
    server.on("/5/on", Port5_ON);  //Associate handler function to path
    server.on("/5/off", Port5_OFF);  //Associate handler function to path
  
    server.begin();                           //Start server
  
    MDNS.addService("http", "tcp", 80);
   }
}

void loop(){

if (Serial.available() > 0) {
  // read the incoming byte:
  incomingByte = Serial.read();
  if((incomingByte == '\r') || (incomingByte == '\n')|| (incomingByte == '\0'))
  {
    comindex = 0;
    if(command[0] == '5')
    {
      if(command[1] == '/')
      {
        if(command[2] == '1')
          digitalWrite(output5, HIGH);
        else if (command[2] == '0')
          digitalWrite(output5, LOW);
      }
    }
    else if (command[0] == '4')
    {
      if(command[1] == '/')
      {
        if(command[2] == '1')
          digitalWrite(output4, HIGH);
        else if (command[2] == '0')
          digitalWrite(output4, LOW);
      }
    }
  }
  else
  {
    command[comindex] = incomingByte;
    if(comindex < 2)
      comindex++;
  }
}

wifiManager.process();

if(WifiSetupSuccessful)
{
  MDNS.update();
  server.handleClient();
}
}
