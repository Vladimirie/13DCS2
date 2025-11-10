<?php
include 'data.php';
include 'header.php';
?>
<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <title>Mérkőzések</title>
</head>
<body>
    <h1>Mérkőzések Listája</h1>

    <?php include 'footer.php'; ?>

    <table border="1" cellpadding="5">
<tr>
  <th>Dátum</th>
  <th>Hazai csapat</th>
  <th>Vendég csapat</th>
  <th>Eredmény</th>
</tr>

<?php
foreach ($matches as $m){
    $homeName = '';
    $awayName = '';
    foreach ($teams as $t) {
        if ($t['id'] == $m['home_team']) $homeName = $t['name'];
        if ($t['id'] == $m['away_team']) $awayName = $t['name'];
    }

    echo "<tr>
            <td>{$m['date']}</td>
            <td><a href='team.php?id={$m['home_team']}'>{$homeName}</a></td>
            <td><a href='team.php?id={$m['away_team']}'>{$awayName}</a></td>
            <td>{$m['home_score']} - {$m['away_score']}</td>
          </tr>";
}
?>
</body>
</html>