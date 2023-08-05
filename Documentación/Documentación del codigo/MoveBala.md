# MoveBala.cs

Este script se encarga de mover las balas hacia arriba y destruirlas después de cierto tiempo o al colisionar con un objeto con la etiqueta "Dragon". Se utiliza en Unity para controlar el comportamiento de las balas disparadas.

## Variables

- `public float velocidad = 5`: Una variable pública que representa la velocidad de movimiento de la bala. Inicializada en 5.

- `public GameObject Bala`: Un GameObject que representa la bala.

- `float time = 0.0f`: Una variable para controlar el tiempo.

## Métodos

- `void Update()`: Método que se llama una vez por fotograma. Mueve el objeto hacia arriba según la velocidad y el tiempo transcurrido desde el último fotograma. Aumenta el tiempo según el tiempo transcurrido desde el último fotograma y comprueba si el tiempo es mayor a 2 segundos. Si es así, destruye el objeto "Bala".

- `void OnTriggerEnter2D(Collider2D collision)`: Método que se llama cuando un objeto colisiona con el objeto que tiene este script. Comprueba si la etiqueta del objeto colisionado es "Dragon". Si es así, destruye el objeto "Bala".

## Funcionamiento

Este script se debe adjuntar a los objetos que representan las balas disparadas en Unity. Cada vez que se actualiza el fotograma, la bala se mueve hacia arriba según la velocidad y el tiempo transcurrido desde el último fotograma. También se aumenta el tiempo. Si el tiempo supera los 2 segundos, la bala se destruye automáticamente. Además, si la bala colisiona con un objeto que tiene la etiqueta "Dragon", la bala se destruye inmediatamente. Esto permite que las balas se muevan hacia arriba y se eliminen después de cierto tiempo o al impactar con un dragón.







<p align="center">
  <img src="/Imagenes/Logo_LunaGhost.png" alt="LunaGhost" width="100" height="100">
</p>