var LibraryMyPlugin ={
 $MyData: {
       reading: false,
       timer: 0,
   //}, 
 
  Handler: function(msg) {
   var voices = window.speechSynthesis.getVoices();
     
     //use google british male voice
    msg.voice = voices[4];
    msg.lang = 'en-GB';
    msg.volume = 1; // 0 to 1
    msg.rate = 1; // 0.1 to 10
    msg.pitch = 1; //0 to 2

  msg.onerror = function(e) {
    speechSynthesis.cancel();
    MyData.reading = false;
    clearInterval(MyData.timer);
  };

  msg.onend = function(e) {
    console.log("On end...");
    // speechSynthesis.cancel();
    MyData.reading = false;
    clearInterval(MyData.timer);
  };

  speechSynthesis.onerror = function(e) {
    speechSynthesis.cancel();
    MyData.reading = false;
    clearInterval(MyData.timer);
  };

  speechSynthesis.speak(msg);

  MyData.timer = setInterval(function() {
    if (speechSynthesis.paused) {
      speechSynthesis.resume();
    }

  }, 100);

  MyData.reading = true;

 }
 
  }, 

  Speak: function (strPointer) {
     if (!MyData.reading) {
    speechSynthesis.cancel();
    if (MyData.timer) {
      clearInterval(MyData.timer);
    }
    //Pointer_stringify  -helper function to convert to a JavaScript string.
    var str = Pointer_stringify(strPointer);
    var msg = new SpeechSynthesisUtterance(str);
 
   if (window.speechSynthesis.getVoices().length > 0) {
      MyData.Handler(msg);
      //Handler(msg);
    }
    // wait on voices to be loaded before fetching list
    window.speechSynthesis.onvoiceschanged = function() {
      MyData.Handler(msg);
    };

   
}
else
{
    speechSynthesis.cancel();
    reading = false;
};
    
  }
  };
  
autoAddDeps(LibraryMyPlugin, '$MyData');
mergeInto(LibraryManager.library, LibraryMyPlugin);