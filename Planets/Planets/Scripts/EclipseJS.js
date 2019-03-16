
// funkcja obsugująca zegar
//function StartTime() {
//    alert("bu");
    // pobranie aktualnej daty 
    /*
    var today = new Date();
    var y = today.getFullYear();
    var m = today.getMonth();
    var d = today.getDate();
    var h = today.getHours();
    */
    // data najbliższego zaćmienia słońca:
    //var yEclipse = 2028;
    //var mEclipse = 6;
    //var dEclipse = 10;
    //var hEclipse = 11;

    // Wyznaczenie różnicy i później jej wyświetlnie
   /*
    yEclipse -=  Number(y);
     mEclipse -= Number(m);
     if (mEclipse < 0) {
         yEclipse--;
         mEclipse *= -1;
     }
     dEclipse -= d;
     if (dEclipse < 0) {
         dEclipse += 31;
     } 
     hEclipse -= h;
     if (hEclipse < 0) {
         dEclipse--;
         hEclipse *= -1;
     }
    */
    // dodaje 0, gdy numer <10
    /*
    yEclipse = checkTime(yEclipse);
    mEclipse = checkTime(mEclipse);
    dEclipse = checkTime(dEclipse);
    hEclipse = checkTime(hEclipse);
    */
    // wyświetlenie w tabeli napisu + czasu do następnego zaćmienia
 /*   document.getElementById("TimerTable").innerHTML =
        '<tr>' +
        '<td>' + " Do najbliższego zaćmienia pozostało: " + '</td>' +
        '</tr>' +
        '<tr>' +
        '<td>' + yEclipse + " y : " + mEclipse + " m : " + dEclipse + " d : " + hEclipse + " h " + '</td>' +
        '</tr>';

    //t = setTimeout(function () { startTime(); }, 500);
*/
//}

// do liczb mniejszych od 10 dodaje z przodu 0
/*function checkTime(i) {
    if (i < 10) {
        i = "0" + i;
    }
    return i;
}
*/

function check() {
    alert("xd");
}