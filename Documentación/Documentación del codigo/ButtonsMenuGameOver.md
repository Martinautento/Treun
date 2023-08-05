# ButtonsMenuGameOver.cs

Este script se encarga del manejo de botones en el menú de Game Over y activa dicho menú cuando el jugador muere. Se utiliza en Unity para controlar la lógica del menú y la interacción con los botones.

## Variables

- `[SerializeField] private GameObject menuGameOver`: Un objeto privado de Unity que se muestra en el Inspector de Unity. Este objeto corresponde al menú de Game Over que se mostrará cuando el jugador muera.

- `private BarraVidaFunciones vidaJugador`: Una variable que almacena una referencia al script "BarraVidaFunciones" adjunto al objeto jugador. Se utiliza para suscribir el método "ActivarMenu" al evento "MuerteJugador" del script "vidaJugador".

## Métodos

- `void Start()`: Método que se llama una vez al inicio del juego. Busca el objeto con la etiqueta "Player" y obtiene el componente "BarraVidaFunciones" adjunto a él, asignándolo a "vidaJugador". Luego, suscribe el método "ActivarMenu" al evento "MuerteJugador" del script "vidaJugador".

- `private void ActivarMenu(object sender, EventArgs e)`: Método privado que se ejecuta cuando el evento "MuerteJugador" del script "vidaJugador" es disparado. Activa el objeto "menuGameOver" para mostrar el menú de Game Over y detiene el tiempo en el juego estableciendo Time.timeScale en 0.

- `public void EscenaJuego()`: Método público que dirige al jugador a la escena de juego, es decir, reinicia la escena.

- `public void EscenaCreditos()`: Método público que dirige al jugador a la escena de créditos.

- `public void BackToMenu()`: Método público que dirige al jugador a la escena del menú principal.

- `public void Exit()`: Método público que se encarga de salir del juego. Si el juego se está ejecutando en el editor de Unity, desactiva el modo de juego. Si el juego se está ejecutando como una aplicación independiente, cierra la aplicación.

## Funcionamiento

Este script se debe adjuntar a un objeto en Unity que controle el menú de Game Over y los botones asociados. Cuando el jugador muere y se dispara el evento "MuerteJugador" del script "vidaJugador", se activa el menú de Game Over mediante el objeto "menuGameOver" y se detiene el tiempo en el juego. Al presionar los botones correspondientes, se realizan las acciones asociadas: reiniciar la escena de juego, ir a la escena de créditos, volver al menú principal o salir del juego, según el botón seleccionado.










<p align="center">
  <img src="/Imagenes/Logo_LunaGhost.png" alt="LunaGhost" width="100" height="100">
  
  **Documentado por Luna Acosta**
</p>