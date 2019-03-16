
/// funkcja obsugująca zegar
function StartTime() {

    // pobranie aktualnej daty 
    var today = new Date();
    var yNow = today.getFullYear();
    var mNow = today.getMonth();
    var dNow = today.getDate();
    var hNow = today.getHours();

    // data najbliższego zaćmienia słońca:
    // pobranie tabeli
    var eclipseTable = document.getElementById('table');
    // pobranie komórki z datą zaćmienia
    var dateString = String(eclipseTable.rows[1].cells[0].innerHTML);

    // wyciąganie ze stringa z datą tylko numer rok
    var yEclipse = dateString.slice(6, 11);

    // wyciąganie tylko miesiąca
    var mEclipse = dateString.slice(3, 5);
    // jeżeli występuje na początku '0' to trzeba je usunąć
    if (mEclipse.charAt(0) == '0') {
        mEclipse = mEclipse.replace("0", "");
    }

    // wyciąganie ze stringa dnia
    var dEclipse = dateString.slice(0, 2);
    // jeżeli występuje na początku '0' to trzeba je usunąć
    if (dEclipse.charAt(0) == '0') {
        dEclipse.replace("0", "");
    }
    // pobranie komórki z godziną zaćmienia
    dateString = String(eclipseTable.rows[1].cells[1].innerHTML);
    hEclipse = dateString.slice(0, 2);

    // Wyznaczenie różnicy i później jej wyświetlnie

    yEclipse -= Number(yNow);
    mEclipse -= Number(mNow);
    if (mEclipse < 0) {
        yEclipse--;
        mEclipse += 12;
    }
    dEclipse -= dNow;
    if (dEclipse < 0) {
        mEclipse -= 1;
        dEclipse += 31;
    }
    hEclipse -= hNow;
    if (hEclipse < 0) {
        dEclipse--;
        hEclipse += 24;
    }

    // dodaje 0, gdy numer <10
    yEclipse = checkTime(yEclipse);
    mEclipse = checkTime(mEclipse);
    dEclipse = checkTime(dEclipse);
    hEclipse = checkTime(hEclipse);

    // wyświetlenie w tabeli napisu + czasu do następnego zaćmienia
    document.getElementById("TimerTable").innerHTML =
        '<tr>' +
        '<td>' + " Do najbliższego zaćmienia pozostało: " + '</td>' +
        '</tr>' +
        '<tr>' +
        '<td>' + yEclipse + " y : " + mEclipse + " m : " + dEclipse + " d : " + hEclipse + " h " + '</td>' +
        '</tr>';

    t = setTimeout(function () { startTime(); }, 1000);
}

// do liczb mniejszych od 10 dodaje z przodu 0
function checkTime(i) {
    if (i < 10) {
        i = "0" + i;
    }
    return i;
}

