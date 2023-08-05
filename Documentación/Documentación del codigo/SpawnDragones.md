# SpawnDragones.cs

Este script controla el spawn de los dragones en el juego. Los dragones son enemigos que aparecen en ubicaciones aleatorias durante el juego y representan una amenaza para el jugador.

## Variables

- `public GameObject[] dragones`: Un array público de GameObjects que representa los diferentes tipos de dragones disponibles en el juego.

- `public Transform DownIzq`: Un Transform que representa la esquina inferior izquierda del área donde pueden aparecer los dragones.

- `public Transform DownDer`: Un Transform que representa la esquina inferior derecha del área donde pueden aparecer los dragones.

- `public Transform UpIzq`: Un Transform que representa la esquina superior izquierda del área donde pueden aparecer los dragones.

- `public Transform UpDer`: Un Transform que representa la esquina superior derecha del área donde pueden aparecer los dragones.

- `public float timerSpawn = 1`: Un valor público que representa el tiempo de espera inicial antes de que aparezca el primer dragón.

- `public float spawnRate = 20`: Un valor público que representa la tasa de aparición de nuevos dragones en segundos.

- `private int cantDragones=6`: Una variable privada que almacena la cantidad de dragones que deben aparecer. Se inicia con un valor de 6.

- `private int randomDragon`: Una variable que almacena un número aleatorio generado para seleccionar un tipo de dragón del array `dragones`.

## Métodos

- `void Start()`: Método que se llama una vez al inicio. Utiliza `InvokeRepeating` para invocar el método `spawn` después de un tiempo de espera (`timerSpawn`) y de manera repetitiva con una tasa específica (`spawnRate`).

- `public void spawn()`: Método para generar el spawn de un dragón. Comprueba si todavía quedan dragones por aparecer (`cantDragones > 0`), calcula una posición aleatoria dentro del área especificada por los Transforms `DownIzq`, `DownDer`, `UpIzq` y `UpDer`, selecciona un tipo de dragón aleatorio del array `dragones` y lo instancia en la posición calculada. Reduce la cantidad de dragones restantes.

## Funcionamiento

Este script debe ser adjuntado a un objeto en el juego que controlará el spawn de los dragones. Cuando se inicia el juego, el método `Start` establece un tiempo de espera inicial y una tasa de aparición de dragones. Luego, el método `spawn` se invoca repetitivamente según la tasa de aparición configurada. Cada vez que se llama `spawn`, un dragón se generará en una posición aleatoria dentro del área definida por los Transforms `DownIzq`, `DownDer`, `UpIzq` y `UpDer`, y será seleccionado aleatoriamente del array `dragones`. Esto resulta en la aparición periódica de diferentes dragones durante el juego, hasta que se generen todos los dragones definidos inicialmente (`cantDragones` llegue a cero).







<p align="center">
  <img src="/Imagenes/Logo_LunaGhost.png" alt="LunaGhost" width="100" height="100">
</p>