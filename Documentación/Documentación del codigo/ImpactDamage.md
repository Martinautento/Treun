# ImpactDamage.cs

Este script se encarga de detectar las colisiones de las balas con los dragones, desactivar los dragones al morir y llamar a la función que modifica el contador de dragones eliminados. Se utiliza en Unity para controlar el comportamiento de los dragones y las interacciones con las balas.

## Variables

- `public int vidaDragon = 10`: Una variable entera pública que representa la vida actual del dragón. Inicializada en 10.

- `private AudioSource audioSource`: Una variable que almacena el componente AudioSource asociado al objeto.

## Métodos

- `void Start()`: Método que se llama una vez al inicio del juego. Obtiene el componente AudioSource adjunto al objeto y lo asigna a "audioSource".

- `void OnTriggerEnter2D(Collider2D collision)`: Método que se llama cuando un objeto colisiona con el objeto que tiene este script. Detecta las colisiones de las balas con los dragones y reduce la vida del dragón según el tipo de colisión. Luego llama a la función "killDragon" para verificar si el dragón debe ser eliminado.

- `IEnumerator RespawnDragon()`: Corutina que se ejecuta para hacer reaparecer al dragón después de cierto tiempo. Espera 20 segundos antes de realizar el respawn del dragón. Luego habilita el componente SpriteRenderer y el Collider2D del dragón, y restablece su vida a 10.

- `public void killDragon(int vida)`: Función para verificar si el dragón debe ser eliminado. Comprueba si la vida del dragón es igual o menor a 0. Si es así, deshabilita el componente SpriteRenderer y el Collider2D del dragón, reproduce el audio asociado al dragón, aumenta el contador de dragones eliminados y comienza la corutina para hacer respawn del dragón después de un tiempo determinado.

## Funcionamiento

Este script se debe adjuntar a los objetos que representan a los dragones en Unity. Cuando una bala colisiona con el dragón, se llama al método "OnTriggerEnter2D". Dependiendo del tag de la bala ("Bala" o "Patito"), se reduce la vida del dragón. Si la vida del dragón es igual o menor a 0, se desactiva el componente SpriteRenderer y el Collider2D del dragón, se reproduce un audio y se aumenta el contador de dragones eliminados en la clase "AumentarContador". Luego, el dragón reaparece después de 20 segundos, reactivando sus componentes y restableciendo su vida a 10.







<p align="center">
  <img src="/Imagenes/Logo_LunaGhost.png" alt="LunaGhost" width="100" height="100">
</p>