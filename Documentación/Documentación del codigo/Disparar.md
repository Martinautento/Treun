# Disparar.cs

Este script en C# se encarga de realizar disparos desde la posición y rotación especificadas por el objeto "controladorDisparo". Se utiliza en Unity para controlar la lógica de los disparos.

## Variables

- `public Transform controladorDisparo`: Un Transform que indica la posición y rotación desde donde se realiza el disparo.

- `public GameObject[] balas`: Un array de GameObjects que representa las diferentes balas disponibles para el disparo.

## Métodos

- `void Update()`: Método que se llama una vez por frame. Comprueba si se presiona la tecla "e" o la barra espaciadora y, en caso afirmativo, llama al método "Disparo()".

- `public void Disparo()`: Método para realizar el disparo. Instancia un objeto aleatorio del array de balas en la posición y rotación del controlador de disparo.

## Funcionamiento

Este script se debe adjuntar a un objeto en Unity que controle la lógica de los disparos. Cada vez que se presiona la tecla "e" o la barra espaciadora, se llama al método "Disparo()". El método "Disparo()" instancia un objeto aleatorio del array de balas en la posición y rotación del controlador de disparo, lo que representa el disparo efectuado desde esa posición. Esto permite tener diferentes tipos de balas disponibles para el disparo y realizar disparos desde distintas posiciones en el juego.







<p align="center">
  <img src="/Imagenes/Logo_LunaGhost.png" alt="LunaGhost" width="100" height="100">
</p>