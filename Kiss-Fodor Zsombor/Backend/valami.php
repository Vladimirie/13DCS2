<?php

$file_path = 'data.json';

$json = file_get_contents( $file_path);

$data = json_decode($json, true);

$termekek = $data['termekek'];
$rendelesek = $data['rendelesek'];
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    
<h2>Raktáron</h2>

<ul>

<?php
//írja ki az összes raktáron lévő termék nevét
for ($i = 0; $i < count($termekek); $i++) {
    if ($termekek[$i]['raktaron'] == true) {
        echo'<li>'. $termekek[$i]['nev'].'</li>';
    }
}
?>
</ul>

<h2>Rendelések</h2>

<ul>

<?php
//ki mit rendelt és mennyit fizetett (plusz még oda írtam mikor :P)
for ($i = 0; $i < count($rendelesek); $i++) {
    $termekId = $rendelesek[$i]['termek_id'] - 1;
    $termekAr = $termekek[$termekId]['ar'] * $rendelesek[$i]['db'];
    echo '<li> Rendelés ideje: '.$rendelesek[$i]['datum'].'. Vevő: '.$rendelesek[$i]['vevo'] . '. Termék neve és ár összesen: ' . $termekek[$termekId]['nev']. ' ' . $termekAr . 'ft.</li>';
}
?>

</ul>

<form action="#" method="post">
<select onchange="this.form.submit()" name="termekek">
	<option value="">Válasz kategoriát</option>
	<option value="gyumolcs">Gyümölcs</option>
	<option value="pekaru">Pékáru</option>
	<option value="tej">Tej</option>
</select>
</form>

<?php
//írja ki az adott kategóriában lévő termékek nevét és, hogy raktáron vannak-e
if (isset($_POST['termekek'])) { 
    $kategoria = $_POST['termekek'];
    foreach ($termekek as $termek) 
    {
        if ($termek['kategoria'] == $kategoria) {
            echo '<p>'. $termek['nev'];
            if ($termek['raktaron'] ) {
                echo ' raktáron</p>';
            }
            else {
                echo ' nincs raktáron</p>';
            }
        }
    }
}
?>

</body>
</html>