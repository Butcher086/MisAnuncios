# MisAnuncios-
sistema de publicación de anuncios de servicios profesionales para autónomos. Los usuarios de la web indican cuáles son sus aptitudes (jardinería, fontanería, cuidado de niños, enseñanza de idiomas, etc…).  El objetivo es ayudar a los autónomos a dar a conocer sus servicios a través de internet. 

La web permite gestionar anuncios de autónomos dentro de cada ciudad donde operen.

Funcionalidad:
- Se pueden crear usuarios mediante el panel de creacion, donde se debe introducir Nombre, Apellidos, Email, Ciudad y Contraseña.
- Existe un administrador de servicios, que se encarga de añadir o quitar los servicios a ofertar.
  (user: rubenrag@outlook.es pass: Az123456:) )
- Existe un panel de creación de Anuncios, por el cual cada usuario puede crear sus propios anuncios, indicando un Titulo, Descripcion del anuncio y la categoría a la que pertenece. Queda restringido la creacion de anuncios a la ciudad a la que pertenece cada usuario.
- La sección de Buscar, consiste en un textbox donde se introduce las palabras clave a buscar en los títulos de los Anuncios. Así por ejemplo si hay anuncios que tienen como título "Limpieza de locales y naves industriales" , si buscamos la palabra clave "locales" y seleccionamos la categoría "Limpieza", nos mostrará los anuncion que lo contiene.
- Por ultimo, se ha añadido en el pie de página el enlace a la API donde muestra los anuncios que han sido creados segun la ciudad introducida. La url de la api es: 
http://misanunciosdx.azurewebsites.net/api/ApiData?ciudad="NOMBRE_CIUDAD"
Donde cambiando el nombre de la ciudad tendremos acceso a dicha información.
Por ejemplo: http://misanunciosdx.azurewebsites.net/api/ApiData?ciudad=madrid
- La web se encuentra alojada en la siguiente URL:
http://misanunciosdx.azurewebsites.net/
