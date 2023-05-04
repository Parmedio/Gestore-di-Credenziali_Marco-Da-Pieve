# Gestore di Credenziali
### Specifiche programma
Creare un programma che permetta di salvare in un database **username** e **password** che vengono inserite dall'utente.  *requisiti password*
1. deve avere almeno 7 caratteri
2. deve avere almeno 1 carattere in maiuscolo
3. deve avere almeno 1 cifra numerica
4. deve avere almeno 1 carattere speciale

### Funzionamento programma
#### Creare e Salvare credenziali
Quando un utente **registra** username e password viene fatta una verifica se nel DB esiste già un utente con quel username, se si restituisco un messaggio di errore.  Se la registrazione va a buon fine viene restituito un numero di matricola (ID univoco).
#### Stampare ricevuta
Il programma da la possibilità di **stampare una ricevuta** di avvenuta registrazione inserendo username e password, nel nostro caso la ricevuta sarà un file csv.  Le informazioni contenute nella ricevuta sono le seguenti:  
1. matricola
2. username
3. password
4. data (che è la data di inserimento delle credenziali utente)
