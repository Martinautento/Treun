# MovePlayer.cs

Este script controla el movimiento del jugador y su capacidad para disparar balas. También maneja los efectos temporales de power-ups adquiridos durante el juego. Se utiliza en Unity para controlar el comportamiento del jugador en el juego.

## Variables

- `public float runSpeed=2`: Una variable pública que representa la velocidad de movimiento del jugador. Inicializada en 2.

- `Rigidbody2D rb2D`: Una variable que almacena el componente Rigidbody2D asociado al objeto del jugador.

- `public Transform controladorDisparo`: Una variable pública que representa el punto de control para el disparo de las balas.

- `public GameObject[] balas`: Un array de GameObjects que representa las diferentes balas disponibles para el disparo.

- `public int TipoBala = 1`: Una variable pública que indica el tipo de bala que se está usando. Inicializada en 1.

- `public float TiempoDisparo = 0.4f`: Una variable pública que representa el tiempo de espera entre disparos. Inicializada en 0.4 segundos.

- `public bool disparo`: Una variable que controla si el jugador puede disparar o no.

- `public int numeroAleatorio`: Una variable que almacena un número aleatorio generado para aplicar efectos temporales a power-ups adquiridos.

- `private AudioSource audioSource`: Una variable que almacena el componente AudioSource asociado al objeto del jugador para reproducir sonidos.

- `[SerializeField] private AudioClip patos`: Un AudioClip que representa el sonido de disparo de pato.

- `[SerializeField] private AudioClip flecha`: Un AudioClip que representa el sonido de disparo de flecha.

## Métodos

- `void Start()`: Método que se llama una vez al inicio. Obtiene el componente Rigidbody2D y AudioSource asociado al objeto del jugador, y establece la escala del tiempo en 1.

- `void FixedUpdate()`: Método que se llama en intervalos regulares y controla el movimiento horizontal del jugador. También dispara balas cuando se presiona la tecla "e" o la barra espaciadora.

- `private void OnTriggerEnter2D(Collider2D collision)`: Método que se llama cuando el jugador entra en contacto con algún objeto. Aplica efectos temporales a power-ups adquiridos.

- `IEnumerator TemporizadorBotas()`: Corrutina que temporiza el efecto de velocidad incrementada por los power-ups de botas.

- `IEnumerator TemporizadorPatos()`: Corrutina que temporiza el efecto de cambio de tipo de bala por los power-ups de patos.

- `IEnumerator EsperaDisparo()`: Corrutina que temporiza el tiempo de espera entre disparos.

- `public void Disparo(int bala)`: Método para realizar el disparo de balas. Instancia un objeto de bala en la posición y rotación del controlador de disparo.

## Funcionamiento

Este script debe ser adjuntado al objeto que representa al jugador en Unity. Controla el movimiento horizontal del jugador mediante las teclas "d" (derecha) y "a" (izquierda). Además, permite que el jugador dispare balas presionando la tecla "e" o la barra espaciadora. El tipo de bala y el tiempo de espera entre disparos pueden cambiar temporalmente cuando el jugador entra en contacto con ciertos objetos del juego. Los efectos temporales de los power-ups son controlados por las corrutinas `TemporizadorBotas()` y `TemporizadorPatos()`. La corrutina `EsperaDisparo()` se encarga de establecer el tiempo de espera entre disparos.







<p align="center">
  <img src="/Imagenes/Logo_LunaGhost.png" alt="LunaGhost" width="100" height="100">
</p>