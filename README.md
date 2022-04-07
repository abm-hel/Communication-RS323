# Communication-RS323

En utilisant un logiciel de simulation, on a 2 ports série virtuels, COM1 et COM2, qui communiquent entre eux. Le logiciel les connecte ensemble.
![image](https://user-images.githubusercontent.com/73439684/162183599-3cc2cae3-4c18-4fee-ad35-27aaac79e578.png)
On a COM1 ouvert (logiciel de simulation de port série), et on ouvre le port COM2 via l’application C# :
En utilisant un logiciel de simulation, on a 2 ports série virtuels, COM1 et COM2, qui communiquent entre eux. Le logiciel les connecte ensemble.
On a COM1 ouvert (logiciel de simulation de port série), et on ouvre le port COM2 via l’application C# :
![image](https://user-images.githubusercontent.com/73439684/162183732-e55e1261-f5d0-4896-9729-d0b0c166b8bf.png)
On peut maintenant commencer à lire et écrire des données sur le COM2.



On écrit « bonjour » dans la boîte de gauche puis on clique sur « envoyer les données ». Sur la fenêtre COM1, qui est d’abord vide, on voit apparaître « bonjour ». Le message a bien été écrit sur le port COM2.

Après, depuis la fenêtre COM1, on écrit dans la barre de texte « salut », et on clique sur « envoyer ».
Dans l’application C#, la boîte de texte noire affiche ce que le port COM2 reçoit. Le COM2 a bien reçu le message « salut ».
