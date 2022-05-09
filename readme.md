## Bowling

```
var game = new BowlingGame();

game.Roll(1);
game.Roll(2);

game.Roll(1);
game.Roll(3);

game.Roll(4);
game.Roll(5);

game.Score // should be 16

// spare:
// 1, 2 => 3
// 3, 7 => 10 + spare bonus 4
// 4, 2 => 6

//  score should be 23

```

## Setup project

```
dotnet restore
```

## Run tests

```
dotnet test
```
