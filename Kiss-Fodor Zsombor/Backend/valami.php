<?php

$file_path = 'data.json';

$json = file_get_contents( $file_path);

$data = json_decode($json, true);

$termekek = $data['termekek'];
$rendelesek = $data['rendelesek'];

echo '<h2>Raktáron</h2>';
echo '<ul>';
for ($i = 0; $i < count($termekek); $i++) {
    if ($termekek[$i]['raktaron'] == true) {
        echo'<li>'. $termekek[$i]['nev'].'</li>';
    }
}

echo '</ul>';

//ki mit rendelt és mennyiért

echo '<h2>Rendelések</h2>';

echo '<ul>';
for ($i = 0; $i < count($rendelesek); $i++) {
    $termekId = $rendelesek[$i]['termek_id'] - 1;
    $termekAr = $termekek[$termekId]['ar'] * $rendelesek[$i]['db'];
    echo '<li> Rendelés ideje: '.$rendelesek[$i]['datum'].'. Vevő: '.$rendelesek[$i]['vevo'] . '. Termék neve és ár összesen: ' . $termekek[$termekId]['nev']. ' ' . $termekAr . 'ft.</li>';
}

echo '</ul>';

?>