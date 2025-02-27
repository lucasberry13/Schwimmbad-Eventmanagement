# Testfälle für das Schwimmbad-Eventmanagementsystem

## **Testfall 1: Teilnehmer zu Event hinzufügen**
**ID:** T01  
**Beschreibung:** Überprüfung, ob ein bestehender Teilnehmer einem Event korrekt hinzugefügt werden kann.  

### **Vorbedingungen:**
- Es existiert mindestens ein Teilnehmer im System.
- Es existiert mindestens ein Event im System.
- Die Funktion „Teilnehmer zu Event zuweisen“ ist implementiert.

### **Test-Schritte:**
1. Die Anwendung starten.
2. Zum Menüpunkt **"Teilnehmer zu Event zuweisen"** navigieren.
3. Einen Teilnehmer aus der Liste auswählen.
4. Ein Event aus der Liste auswählen.
5. Den Button **"Teilnehmer zuweisen"** anklicken.
6. Die Liste der zugewiesenen Teilnehmer für das Event überprüfen.

### **Erwartetes Resultat:**
- Der Teilnehmer wird erfolgreich dem Event hinzugefügt.
- Die Zuweisung wird in der Datenbank gespeichert.
- Der Teilnehmer erscheint in der Liste der Teilnehmer für das Event.
- Eine Bestätigungsmeldung wird angezeigt.

---

## **Testfall 2: Teilnehmer aus Event entfernen**
**ID:** T02  
**Beschreibung:** Überprüfung, ob ein Teilnehmer aus einem Event korrekt entfernt werden kann.  

### **Vorbedingungen:**
- Es existiert mindestens ein Teilnehmer, der einem Event zugewiesen ist.
- Die Funktion „Teilnehmer aus Event entfernen“ ist implementiert.

### **Test-Schritte:**
1. Die Anwendung starten.
2. Zum Menüpunkt **"Event-Details anzeigen"** navigieren.
3. Ein Event auswählen, dem mindestens ein Teilnehmer zugewiesen ist.
4. In der Liste der Teilnehmer einen Teilnehmer auswählen.
5. Den Button **"Teilnehmer entfernen"** anklicken.
6. Die Liste der Teilnehmer des Events erneut überprüfen.

### **Erwartetes Resultat:**
- Der Teilnehmer wird erfolgreich aus dem Event entfernt.
- Die Änderung wird in der Datenbank gespeichert.
- Der Teilnehmer erscheint nicht mehr in der Liste der Teilnehmer für das Event.
- Eine Bestätigungsmeldung wird angezeigt.
