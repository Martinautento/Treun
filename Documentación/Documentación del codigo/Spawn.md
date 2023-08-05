# Spawn.cs

Este script controla el spawn de los Power-Ups en el juego. Los Power-Ups son objetos que aparecen en ubicaciones aleatorias durante el juego y que el jugador puede recoger para obtener beneficios temporales o desencadenar acciones específicas.

## Variables

- `public GameObject[] powerUps`: Un array público de GameObjects que representa los diferentes tipos de Power-Ups disponibles en el juego.

- `public float timerSpawn = 1`: Un valor público que representa el tiempo de espera inicial antes de que aparezca el primer Power-Up.

- `public float spawnRate = 60`: Un valor público que representa la tasa de aparición de nuevos Power-Ups en segundos.

- `public Transform DownIzq`: Un Transform que representa la esquina inferior izquierda del área donde pueden aparecer los Power-Ups.

- `public Transform DownDer`: Un Transform que representa la esquina inferior derecha del área donde pueden aparecer los Power-Ups.

- `public Transform UpIzq`: Un Transform que representa la esquina superior izquierda del área donde pueden aparecer los Power-Ups.

- `public Transform UpDer`: Un Transform que representa la esquina superior derecha del área donde pueden aparecer los Power-Ups.

- `public int randomPowerUP`: Una variable que almacena un número aleatorio generado para seleccionar un Power-Up del array `powerUps`.

## Métodos

- `void Start()`: Método que se llama una vez al inicio. Utiliza `InvokeRepeating` para invocar el método `spawn` después de un tiempo de espera (`timerSpawn`) y de manera repetitiva con una tasa específica (`spawnRate`).

- `public void spawn()`: Método para generar el spawn de un Power-Up. Calcula una posición aleatoria dentro del área especificada por los Transforms `DownIzq`, `DownDer`, `UpIzq` y `UpDer`, selecciona un Power-Up aleatorio del array `powerUps` y lo instancia en la posición calculada.

## Funcionamiento

Este script debe ser adjuntado a un objeto en el juego que controlará el spawn de los Power-Ups. Cuando se inicia el juego, el método `Start` establece un tiempo de espera inicial y una tasa de aparición de Power-Ups. Luego, el método `spawn` se invoca repetidamente según la tasa de aparición configurada. Cada vez que se llama `spawn`, un Power-Up se generará en una posición aleatoria dentro del área definida por los Transforms `DownIzq`, `DownDer`, `UpIzq` y `UpDer`, y será seleccionado aleatoriamente del array `powerUps`. Esto resulta en la aparición periódica de diferentes Power-Ups durante el juego.











<p align="center">
  <img src="/Imagenes/Logo_LunaGhost.png" alt="LunaGhost" width="100" height="100">
  
  **Documentado por Luna Acosta**
</p>