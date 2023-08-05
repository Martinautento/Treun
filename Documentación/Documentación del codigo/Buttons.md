# Buttons.cs

Este script proporciona funcionalidades para los botones del juego.

## Métodos

- `public void EscenaJuego()`: Método que carga la escena de juego ("Juego") cuando se pulsa el botón asociado.

- `public void EscenaCreditos()`: Método que carga la escena de créditos ("Creditos") cuando se pulsa el botón asociado.

- `public void BackToMenu()`: Método que carga la escena de menú ("Menu") cuando se pulsa el botón asociado.

- `public void Exit()`: Método que se encarga de salir del juego. Si el juego se está ejecutando en el editor de Unity, desactiva el modo de juego. Si el juego se está ejecutando como una aplicación independiente, cierra la aplicación.

## Funcionamiento

Este script se asocia a los botones del juego en Unity. Cuando el jugador pulsa un botón correspondiente, se ejecuta la funcionalidad asociada. Por ejemplo, al pulsar el botón de "Jugar", se carga la escena del juego. Al pulsar el botón de "Créditos", se carga la escena de créditos. Al pulsar el botón de "Volver al Menú", se carga la escena del menú principal. Y al pulsar el botón de "Salir", el comportamiento depende de si el juego se está ejecutando en el editor de Unity o como una aplicación independiente. En el editor, desactiva el modo de juego, y como aplicación, cierra la aplicación.









<p align="center">
  <img src="/Imagenes/Logo_LunaGhost.png" alt="LunaGhost" width="100" height="100">
  **Documentado por Luna Acosta**
</p>