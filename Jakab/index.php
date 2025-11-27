<?php

include_once("config.php");

$stmt = $db->prepare("SELECT * FROM user");
$stmt->execute();

echo "<table>";
echo "<tr>
<th>ID</th>
<th>Username</th>
<th>Fullname</th>
<th>E-mail<th>
</tr>";

foreach ($stmt as $row) {
    echo "<tr>";
    echo "<td>" . $row['ID'] . "</td>";
    echo "<td>" . $row['Username'] . "</td>";
    echo "<td>" . $row['Fullname'] . "</td>";
    echo "<td>" . $row['Email'] . "<br>";
    echo "</tr>";
}

echo "</table>";

?>
<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <table>
        <tr>
        <th>

        </th>
        </tr>
    </table>
</body>
</html>


