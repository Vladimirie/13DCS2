function Mentes() {
    //alert("ez jó!");
    let nev = document.getElementById("nevInput").value;
    let ido = document.getElementById("idoPont").value;
    let sport = document.getElementById("sport").value;
    let berlet = document.getElementById("berletInput").value;
    let adat = {nev, ido, sport, berlet};
    
    let storage = JSON.parse(localStorage.getItem("programok") || "[]");
    storage.push(adat);
    localStorage.setItem("programok", JSON.stringify(storage));
    
    Reset();
}

function Megjelenit() {
    //alert("ez is jó!");
    let storage = JSON.parse(localStorage.getItem("programok") || "[]");
    let html = "<table> <tr> <th>Név</th> <th>Időpont</th> <th>Sport</th> <th>Bérlet</th></tr>";

    storage.forEach(element => {
        html += "<tr> <td>"+ element.nev +"</td> <td>" + element.ido +"</td> <td>" + element.sport +"</td> <td>"+ + element.berlet +"</td></tr>";
    });

    html += "</table>";
    document.getElementById("adatok").innerHTML = html;
}

function Reset() {
    document.getElementById("nevInput").value = '';
    document.getElementById("idoPont").value = '9:00-10:00';
    document.getElementById("sport").value = 'Aerobik';
    document.getElementById("berletInput").value = '';
}