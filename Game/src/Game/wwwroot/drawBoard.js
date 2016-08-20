
var canvas = document.getElementById('myCanvas');
var context = canvas.getContext('2d');
let hLength = 300;
let vLength = 200;
let rows = 3;
let columns = 4;

function drawCanvas() {
    

  //  var circle = canvas.getContext('2d');

    let hStep = hLength / columns;
    let vStep = vLength / rows;
    let start = { x: 0, y: 0 };
    let end = { x: 0, y: 0 };
    function drawRectangle(start, height) {
        context.beginPath();
        context.rect(start.x, start.y, height.x, height.y);
        context.strokeStyle = 'gray';
        context.stroke();
    }
    for (let i = 0; i < rows; i++) {
        end.y += vStep;
        for (let j = 0; j < columns; j++) {
            end.x += hStep;
            drawRectangle(start, end);
            start.x += hStep;
        }
        start.y += vStep;
        end.x = 0;
        start.x = 0;
    }
    
    //circle.beginPath();
    //circle.arc(xPos, yPos, 40, 0, 180);
    //circle.fillStyle = 'green';
    //circle.fill();
    //circle.stroke();

    //function down() {
    //    context.clearRect(xPos - 41, yPos - 41, xPos + 41, yPos + 41);
    //    console.log("Clear coordinates " + (xPos - 41) + " " + (yPos - 41) + " " + (xPos + 41) + " " + (yPos + 41));
    //    circle.beginPath();
    //    yPos += 100;
    //    console.log(yPos);
    //    circle.arc(xPos, yPos, 40, 0, 180);
    //    circle.lineWidth = 1;
    //    circle.fillStyle = 'green';
    //    circle.fill();
    //    circle.stroke();
    //}
    //function up() {
    //    context.clearRect(xPos - 41, yPos - 41, xPos + 41, yPos + 41);
    //    console.log("Clear coordinates " + (xPos - 41) + " " + (yPos - 41) + " " + (xPos + 41) + " " + (yPos + 41));
    //    circle.beginPath();
    //    yPos -= 100;
    //    console.log(yPos);
    //    circle.arc(xPos, yPos, 40, 0, 180);
    //    circle.lineWidth = 1;
    //    circle.fillStyle = 'green';
    //    circle.fill();
    //    circle.stroke();
    //}
    //function right() {
    //    context.clearRect(xPos - 41, yPos - 41, xPos + 41, yPos + 41);
    //    console.log("Clear coordinates " + (xPos - 41) + " " + (yPos - 41) + " " + (xPos + 41) + " " + (yPos + 41));
    //    circle.beginPath();
    //    xPos += 100;
    //    console.log(xPos);
    //    circle.arc(xPos, yPos, 40, 0, 180);
    //    circle.lineWidth = 1;
    //    circle.fillStyle = 'green';
    //    circle.fill();
    //    circle.stroke();
    //}
    //function left() {
    //    context.clearRect(xPos - 41, yPos - 41, xPos + 41, yPos + 41);
    //    console.log("Clear coordinates " + (xPos - 41) + " " + (yPos - 41) + " " + (xPos + 41) + " " + (yPos + 41));
    //    circle.beginPath();
    //    xPos -= 100;
    //    console.log(xPos);
    //    circle.arc(xPos, yPos, 40, 0, 180);
    //    circle.lineWidth = 1;
    //    circle.fillStyle = 'green';
    //    circle.fill();
    //    circle.stroke();
    //}
}

