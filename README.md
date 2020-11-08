# Museo Interactivo


## Descripción del Proyecto
El Museo Interactivo es un proyecto con enfoque cultural que busca el enlace con las herramientas de inteligencia artificial como reconocimiento de voz y de imagen, para ampliar el conocimiento sobre las tradiciones mexicanas.

## Qué hace el proyecto?
El Museo virtual es capaz de interactuar con el usuario a través de voz y procesamiento de imágenes.
Se le pueden hacer preguntas generales ("quien eres, como estas, hola, etc..."), preguntas acerca el día de muertos y preguntas acerca de ciertas artesanías prehispánicas de la región centro del país (Qro, Gto, EdoMex) todo esto a través de voz.
De igual manera le puedes mostrar imágenes alusivas al día de muertos (pan de muerto, cempasúchil, etc...) o artesanías prehispánicas y el museo te conesta con una explicación a través de un sintetizador de voz.


## Cómo funciona (Tecnologías utilizadas)?

Las tecnologías utilizadas fueron:
  * Azure Speech Recognition
  * Azure Speech to Text
  * Azure Text to Speech
  * Azure Custom Vision
  * Azure QnA
  
 
 ## Cómo lo hace?
 
El código esta escrito en C#, se escogió este lenguaje debido a que al ser parte de Microsoft, se garantiza un 100% de compatibilidad con azure, y además porque el IDE te proporciona un entorno para el diseño de la GUI.
Se mandan a llamar las tecnologías a través de APIs utilizando funciones POST y recibiendo un onjeto JSON con la respuesta del servidor.

Se entrenó un QnA con varias preguntas (Ver archivo en Azure/QnA/)
Se entrenó un CustomVision con varias imágenes(Ver archivo en Azure/Vision/) alusivas a día de muertos y aretesanías

Secuencia Voz:
 1) Se enciende Microfono
 2) Se interpreta la voz del usuario a travez de Azure.SpeechtoText
 3) La pregunta del usuario (convertida en texto) se envia a través de un API a Azure.QnA
 4) Se filtra el JSON proveniente de Azure.QnA para obtener el text de Respuesta
 5) A través de Azure.TextToSpeech se menciona al usurio la respuesta
 
 Secuencia Imágenes:
 1) Se enciende WebCam
 2) Se captura la imágen del objeto
 3) Se convierte la imagen a un arreglo de bytes
 4) Se envia el arreglo de bytes a través de un API a Azure.ImageRecognition
 5) Se filtra el JSON de respuesta
 6) La respuesta de Azure.ImageRecognition se envía al QnA a través de un API
 7) A través de Azure.TextToSpeech se menciona al usurio la respuesta
 
 
 ## Retos
En un inicio el concepto estaba claro lo que se quería hacer, en base a esto sabíamos que teníamos todo lo necesario para ejecutar la idea, el principal problema fue juntar todos los recursos en uno solo.
 *Averiguar como ensamblar todos los componentes que ya teníamos.
 *Convertir la respuesta al idioma español
 *Terminal de Git
 *Elaboración de Videos/Animaciones
 
 ## Qué aprendimos?
Desde un inicio aprendimos a plasmar nuetras ideas, ya que desde un incio se nos complico el aterrizarlas, saber que era lo que queriamos crear, aprendimos a trabajar en equipo y no fue complicado, ya que todos tuvimos la iniciativa de trabajar y aportar en lo que podiamos.
Aprendimos a solucionar diversos problemas que fuimos teniendo en el proyecto pero cada uno fue solucionado, asi obteniendo mucha mas experiencia, sobre los servicios cognitivos, saber como y cuando utilizarlos.

 ## Qué sigue?
Nuestro proyecto fue pensado para ser escalable en diversas áreas, desde las culturales, para estar en museos físicos y agregar un plus a estos creando una experiencia más atractiva para todas las personas que lo visiten, añadiendo tradiciones y costumbres típicas de cada zona del país para poder hacer más diversa la información, hasta estar ubicado en plazas comerciales en la que los usuarios puedan hacer preguntas de los productos o servicios que estén en ese entorno
 
 ## Integrantes (Nombre - Email)
Celeste Estefanía Tello Argüelles  viajero31354@innovaccion.mx
Diego Joshua Cruz Rojas            viajero27493@innovaccion.mx 
Juan Jose Retana Gonzalez          viajero02370@innovaccion.mx 
Augusto López Ruiz                 viajero08260@innovaccion.mx


