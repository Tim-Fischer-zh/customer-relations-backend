# Kundenmanagement System

Dies ist mein privates Projekt zur Verwaltung von Kunden, Verträgen, Projekten und Rechnungen. Ich setze dieses System in meinem Homelab zuhause ein – entweder auf einem SQL- oder NoSQL-Server – und baue darauf eine .NET API mit Authentifizierung und Rate Limiting. Das Frontend realisiere ich entweder mit Angular oder Laravel.

## Übersicht

Ich entwickle dieses System, um meine Kunden- und Vertragsdaten effizient zu verwalten und dabei maximale Flexibilität und Sicherheit zu gewährleisten. Die Architektur umfasst folgende Kernkomponenten:

- **Datenbank:**  
  Einsatz eines SQL- oder NoSQL-Servers in meinem Homelab zur sicheren und performanten Speicherung aller Daten.

- **Backend:**  
  Eine .NET API, die mittels Authentifizierung und Rate Limiting den Zugriff auf die Daten steuert und schützt.

- **Frontend:**  
  Eine moderne, responsive Benutzeroberfläche, umgesetzt mit Angular oder Laravel, um eine intuitive Interaktion mit dem System zu ermöglichen.

## Datenmodell

![Datenmodell](/Documentation/DatabaseSchema.svg)

Das obige Diagramm (importierbar via diagrams.net) visualisiert mein Datenmodell mit den Entitäten **Customers**, **Contracts**, **Projects** und **Invoices** sowie deren Beziehungen.

## Geplante Features

- **Homelab-Betrieb:**  
  Nutzung eines eigenen Servers (SQL oder NoSQL) in meinem Homelab für optimale Kontrolle und Flexibilität.

- **Sichere API:**  
  Entwicklung einer .NET API mit integrierter Authentifizierung und Rate Limiting, um unbefugten Zugriff und Missbrauch zu verhindern.

- **Modernes Frontend:**  
  Aufbau einer ansprechenden und benutzerfreundlichen Oberfläche mit Angular oder Laravel, je nach Projektanforderung.

- **Erweiterbarkeit:**  
  Möglichkeit, das System künftig um zusätzliche Features wie detaillierte Berichte, Dashboards und weitere Management-Tools zu erweitern.

## Persönlicher Anwendungsfall

Dieses Projekt ist für mich ein zentrales Tool im privaten Kundenmanagement. Es ermöglicht mir, alle relevanten Informationen zu Kunden, Verträgen, Projekten und Rechnungen an einem Ort zu bündeln und bei Bedarf schnell darauf zuzugreifen. Mit der fortlaufenden Erweiterung des Systems passe ich es kontinuierlich an meine individuellen Bedürfnisse an.


## Installation
Für die Datebank verwende ich einen MySQL Server. Zu dem ist das Tool das ich verwende MySQL Workbench.
```bash
brew services start mysql #auf MacOS über brew den Service MySQL starten.
mysql -u root #verbindung testen
```