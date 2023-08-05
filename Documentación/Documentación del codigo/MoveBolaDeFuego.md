# MoveBolaFuego.cs

Este script se encarga de mover las bolas de fuego hacia abajo y destruirlas después de cierto tiempo o al colisionar con un objeto con la etiqueta "Player". Se utiliza en Unity para controlar el comportamiento de las bolas de fuego.

## Variables

- `public float velocidad = 4`: Una variable pública que representa la velocidad de movimiento de la bola de fuego. Inicializada en 4.

- `public GameObject Bala`: Un GameObject que representa la bola de fuego.

- `float time = 0.0f`: Una variable para controlar el tiempo.

## Métodos

- `void Update()`: Método que se llama una vez por fotograma. Mueve el objeto hacia abajo según la velocidad y el tiempo transcurrido desde el último fotograma. Aumenta el tiempo según el tiempo transcurrido desde el último fotograma y comprueba si el tiempo es mayor a 2 segundos. Si es así, destruye el objeto "Bala".

- `void OnTriggerEnter2D(Collider2D collision)`: Método que se llama cuando un objeto colisiona con el objeto que tiene este script. Comprueba si la etiqueta del objeto colisionado es "Player". Si es así, destruye el objeto "Bala".

## Funcionamiento

Este script se debe adjuntar a los objetos que representan las bolas de fuego en Unity. Cada vez que se actualiza el fotograma, la bola de fuego se mueve hacia abajo según la velocidad y el tiempo transcurrido desde el último fotograma. También se aumenta el tiempo. Si el tiempo supera los 2 segundos, la bola de fuego se destruye automáticamente. Además, si la bola de fuego colisiona con un objeto que tiene la etiqueta "Player", se destruye inmediatamente. Esto permite que las bolas de fuego se muevan hacia abajo y se eliminen después de cierto tiempo o al impactar con el jugador.







<p align="center">
  <img src="/Imagenes/Logo_LunaGhost.png" alt="LunaGhost" width="100" height="100">
</p>