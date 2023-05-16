// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let value;
let totalMoves = 10;
let playerScore = 0;
let computerScore = 0;
let result = document.querySelector('.result');



function getData() {
    let options = ['rock', 'paper', 'scissor'];
    options.forEach((option) => {
        let btn = document.querySelector(`.${option}`);
        btn.addEventListener('click', (a) => {
            console.log(totalMoves)
            var moves = document.querySelector('.option__head');
            if (totalMoves > 0) {
                totalMoves--;
                moves.innerHTML = `Choose your move. Moves left - ${totalMoves}`;
                let random = Math.floor(Math.random() * 3);
                const computerMove = options[random];
                rps(option, computerMove);
            }

            if (totalMoves == 0) {
                var restart = document.querySelector('.restart');
                restart.style.display = 'block';
                if (playerScore == computerScore) {
                    result.innerHTML = "This game is a draw";
                } else if (playerScore > computerScore) {
                    result.innerHTML = value ? "Congratulations " + value + "! you won this game" : "Congratulations! you won this game";
                } else if (playerScore < computerScore) {
                    result.innerHTML = value ? "Sad " + value + "! you lost this game" : "Sad! you lost this game";
                }
            }
        });
    });
};

function rps(user, computer) {
    let _userScore = document.querySelector('.user__score');
    let _computerScore = document.querySelector('.computer__score');
    let userMove = document.querySelector(".user__move");
    let computerMove = document.querySelector(".computer_move");
    let emoji = {
        rock: '👊',
        paper: '✋',
        scissor: '✌️'
    };
    userMove.innerHTML = emoji[user];
    computerMove.innerHTML = emoji[computer];
    result.style.display = 'block';

    if (user == computer) {
        result.innerHTML = "It's a tie";
    } else if (user == 'rock') {
        if (computer == 'paper') {
            result.innerHTML = "Computer won";
            computerScore++;
        } else if (computer == 'scissor') {
            result.innerHTML = "You won";
            playerScore++;
        }
    } else if (user == 'paper') {
        if (computer == 'rock') {
            result.innerHTML = "You won";
            playerScore++;
        } if (computer == 'scissor') {
            result.innerHTML = "Computer won";
            computerScore++;
        }
    } else if (user == 'scissor') {
        if (computer == 'rock') {
            result.innerHTML = "Computer won";
            computerScore++;
        } else if (computer == 'paper') {
            result.innerHTML = "You won";
            playerScore++;
        }
    }
    _userScore.innerHTML = playerScore;
    _computerScore.innerHTML = computerScore;
};

function restart() {
    document.querySelector('.restart').addEventListener('click', () => {
        window.location.reload();
    });
};

getData();
restart();