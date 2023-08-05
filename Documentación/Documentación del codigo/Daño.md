# Daño.cs

Este script se encarga de inicializar las bolas de fuego de los dragones. Se utiliza en Unity para controlar el comportamiento de los disparos de las bolas de fuego.

## Variables

- `public GameObject balaFuego`: Una variable pública que representa un GameObject llamado "balaFuego". Este objeto es la bola de fuego que será disparada por el dragón.

- `public Transform controladorDisparo`: Una referencia al punto de control para el disparo de la bala de fuego. Indica la posición y rotación desde donde se dispara la bola de fuego.

- `Rigidbody2D rb2D`: Una variable que almacena el componente Rigidbody2D asociado al objeto. Se utiliza para controlar el movimiento del objeto.

- `public bool disparo`: Una variable que indica si el dragón puede disparar una bola de fuego o no.

- `[SerializeField] int time`: Una variable que determina el tiempo de espera para el próximo disparo de la bola de fuego. El valor varía según cada dragón.

## Métodos

- `void Start()`: Método que se llama una vez al inicio del juego. Obtiene el componente Rigidbody2D adjunto al objeto y lo asigna a "rb2D". Establece la variable "disparo" en true e inicia una corutina para controlar el tiempo de espera entre disparos.

- `void FixedUpdate()`: Método que se llama en intervalos fijos del juego. Comprueba si el dragón puede realizar un disparo. Si es posible, inicia una corutina de espera y realiza el disparo llamando al método "Disparo()".

- `IEnumerator EsperaDisparo()`: Corutina para esperar un tiempo determinado antes de permitir el próximo disparo. Espera 15 segundos antes de establecer "disparo" en false.

- `IEnumerator EsperaDisparoBebe()`: Corutina para esperar un tiempo determinado (dependiendo del valor de "time") antes de permitir el próximo disparo. Espera el tiempo especificado en "time" antes de establecer "disparo" en false.

- `public void Disparo()`: Método para realizar el disparo. Instancia un objeto "balaFuego" en la posición y rotación del controlador de disparo.

## Funcionamiento

Este script se debe adjuntar a los objetos que representan a los dragones en Unity. Cuando se inicia el juego, se establece la variable "disparo" en true, lo que permite que el dragón realice el primer disparo. Después de disparar, se inicia una corutina de espera para controlar el tiempo entre cada disparo. Dependiendo de la etiqueta del objeto (si es un "Dragon" o un "Bebe"), se usa la corutina `EsperaDisparoBebe()` con un tiempo específico o `EsperaDisparo()` con un tiempo fijo. Cuando se cumple el tiempo de espera, la variable "disparo" se establece en false, lo que permite que el dragón realice otro disparo. Al llamar al método `Disparo()`, se instancia un objeto "balaFuego" en la posición y rotación del controlador de disparo, lo que representa el disparo de la bola de fuego.











<p align="center">
  <img src="/Imagenes/Logo_LunaGhost.png" alt="LunaGhost" width="100" height="100">
  **Documentado por Luna Acosta**
</p>