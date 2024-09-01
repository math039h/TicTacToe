using TicTacToe;

var playerOne = new Player();
var playerTwo = new Player();

var ticTacToe = new TicTacToe.TicTacToe(playerOne, playerTwo);

ticTacToe.SetUp();

ticTacToe.GameLoop();