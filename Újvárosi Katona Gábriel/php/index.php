<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    
 <h1> Űrlap kezeélse</h1>
    <form action="" method="post">
        <label for="name">Név: </label>
        <input type="text" name="name" id="name">
        <br><br>
        <label for="lakhely">lakhely: </label>
        <input type="text" name="lakhely" id="lakhely">
        <br><br>
        <label for="age">Kor:</label>
        <input type="text" name="age" id="age">
        <br><br>
        <label for="male">Férfi</label>
        <input type="radio" name="sex" value="male" id="male">
        <label for="female">Nő</label>
        <input type="radio" name="sex" id="felmale" value="female">
        
        <input type="submit" name="submit" id="submit" value="Submit" >

    </form>


</body>
</html>

<?php

if (isset($_POST['submit'])) {
    $nev = $_POST['name'];
    $kor = $_POST['age'];
    $lakhely = $_POST['lakhely'];

    $nem = $_POST['sex'];
    if ($nem == "male") {
        echo "szevasz Faszi";
    } else if ($nem == "female") {
        echo "szevasz Nénje";
    }
    


}




?>