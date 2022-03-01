Order of each line: Tile/Door/RoomWall, xPos, yPos, enemy(if there is one, otherwise empty), item(if there is one, otherwise empty)

A gridspot with a tile would be -> tileName, xPos, yPos,,
A gridspot with a tile and enemey -> tileName, xPos, yPos, enemyName,
A gridspot with a tile and item -> tileName, xPos, yPost,,itemName
A gridspot with tile, enemy, and item -> tileName, xPos, yPos, enemyName, itemName

I would reccomend looking at Room10.csv, which has an example of all these cases.
