# BarraVidaFunciones.cs

Este script se encarga de modificar la barra de vida del jugador, detectar cuando las bolas de fuego le hacen daño y mostrar el menú correspondiente cuando el jugador muere. 

## Variables

- `public Image Vida`: Una variable pública que representa una imagen en Unity y se utiliza para mostrar la barra de vida del jugador.

- `public float VidaActual`: Una variable pública que almacena el valor actual de la vida del jugador.

- `public float VidaMaxima`: Una variable pública que establece el valor máximo de vida del jugador, inicializada en 100.

- `public event EventHandler MuerteJugador`: Un evento que se dispara cuando el jugador muere. Permite que otros scripts se suscriban para ser notificados cuando esto ocurra.

## Métodos

- `void Update()`: Un método que se llama cada cuadro del juego y va actualizando la barra de vida para reflejar los cambios en la vida actual del jugador.

- `public void HacerDaño(float daño)`: Un método público que aplica daño al jugador. Reduce la vida actual del jugador según el valor de "daño". Si la vida actual es menor o igual a cero, dispara el evento `MuerteJugador`, notificando que el jugador ha muerto, y destruye el objeto asociado al script.

- `void OnTriggerEnter2D(Collider2D collision)`: Un método que se llama cuando el objeto con el script colisiona con otro objeto en 2D. Detecta si la colisión es con una "BolaFuegoNormal" o "BolaFuego" y aplica el daño correspondiente llamando al método `HacerDaño()`.

## Funcionamiento

Este script se debe adjuntar a un objeto en Unity que represente al jugador. La barra de vida se muestra mediante la variable pública `Vida` que debe estar vinculada a una imagen en la interfaz de usuario. El método `Update()` actualiza la barra de vida en cada cuadro del juego para reflejar los cambios en la vida actual del jugador.

Cuando el jugador colisiona con una "BolaFuegoNormal" o "BolaFuego", el método `OnTriggerEnter2D` detecta la colisión y llama al método `HacerDaño()` para aplicar el daño adecuado. Si la vida del jugador llega a cero o menos, se dispara el evento `MuerteJugador` para notificar que el jugador ha muerto. Luego, el objeto con este script se destruye.









<p align="center">
  <img src="/Imagenes/Logo_LunaGhost.png" alt="LunaGhost" width="100" height="100">
  **Documentado por Luna Acosta**
</p>