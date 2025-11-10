<?php
$current = basename($_SERVER['PHP_SELF']); // pl. "teams.php"
?>
<!DOCTYPE html>
<html lang="hu">
<head>
  <meta charset="UTF-8">
  <title>Sport Liga</title>
  <link rel="stylesheet" href="style.css">
</head>
<body>

<header>
  <h1>Magyar Sport Liga</h1>
  <nav>
    <ul>
      <li><a href="teams.php" class="<?php if($current == 'teams.php') echo 'active'; ?>">Csapatok</a></li>
      <li><a href="players.php" class="<?php if($current == 'players.php') echo 'active'; ?>">Játékosok</a></li>
      <li><a href="matches.php" class="<?php if($current == 'matches.php') echo 'active'; ?>">Mérkőzések</a></li>
    </ul>
  </nav>
</header>

<main></main>