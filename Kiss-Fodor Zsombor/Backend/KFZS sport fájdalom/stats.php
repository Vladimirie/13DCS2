<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Statisztikák</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-sRIl4kxILFvY47J16cr9ZwB07vP4J8+LH7qKQnuqkuIAvNWLzeN8tE5YBujZqJLB" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/js/bootstrap.bundle.min.js" integrity="sha384-FKyoEForCGlyvwx9Hj09JcYn3nv7wiPVlz7YYwJrWVcXK/BmnVDxM+D2scQbITxI" crossorigin="anonymous"></script>
    <link href="sportStyle.css" rel="stylesheet">
</head>
<body>
<nav class="navbar navbar-expand-lg bg-body-tertiary">
  <div class="container-fluid fideszmod">
    <a class="navbar-brand" href="index.php">FUTBOOL!</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
      <div class="navbar-nav">
        <a class="nav-link" href="teams.php">Csapatok</a>
        <a class="nav-link" href="#">Játékosok</a>
        <a class="nav-link" href="matches.php">Mérkőzések</a>
        <a class="nav-link active" aria-current="page" href="stats.php">Statisztikák</a>
      </div>
    </div>
  </div>
</nav>

<div class="fideszmod">
<h1>Statisztikák</h1>
<?php

$jsonFile = file_get_contents('sports_data.json');
$jsonData = json_decode($jsonFile, associative: true);

$teams = $jsonData['teams'];
$players = $jsonData['players'];
$matches = $jsonData['matches'];

echo '<h2 class="stat">Legtöbb gólt szerzett játékos: ';

$max = $players[0]['goals'];
$topscorePlayerName = 'jóska pista';
//echo $max;
foreach ($players as $player) {
    if($player['goals'] > $max) {
        $topscorePlayerName = $player['name'];
        $max = $player['goals'];
    }
}
echo $topscorePlayerName .' ('. $max.')</h2>';

echo '<h2 class="stat">Legtöbb győzelmet szerző csapat: </h2>';
for ($i = 0; $i < count($teams); $i++) {

}

echo '<h2 class="stat">Döntetlen mérkőzések száma: ';

$drawMatches = 0;

foreach ($matches as $match) {
    if ($match['home_score'] == $match['away_score']) {
        $drawMatches++;
    }
}
echo $drawMatches. '</h2>';

echo '<h2 class="stat">Összes gól a bajnokságban: ';

$allGoals = 0;

foreach ($matches as $match) {
    $allGoals += $match['home_score'];
    $allGoals += $match['away_score'];
}

echo $allGoals. '</h2>';

echo '<h2 class="stat">Csapatonként összesített gólmennyiség: </h2>'; //(összeadva a meccsek eredményeiből)


?>
</div>
</body>
</html>