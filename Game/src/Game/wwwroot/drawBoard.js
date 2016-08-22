
var canvas = document.getElementById('myCanvas');
var context = canvas.getContext('2d');
let hLength = 300;
let vLength = 200;
let rows = 3;
let columns = 3;
let hStep = hLength / columns;
console.log("Pasul orizontal " + hStep);
let vStep = vLength / rows;
console.log("Pasul vertical " + vStep);
let radius = hStep / 2 * 0.8;
if (hStep>vStep) {
    radius = vStep/2*0.8;
}
let figPos = { x: hStep / 2, y: vStep / 2 };
function drawCanvas() {
    let start = { x: 0, y: 0 };
    let end = { x: 0, y: 0 };
    function drawRectangle(start, height) {
        context.beginPath();
        context.rect(start.x, start.y, height.x, height.y);
        context.lineWidth = 1;
        context.strokeStyle = 'gray';
        context.stroke();
    }
    for (let i = 0; i < rows; i++) {
        end.y += vStep;
        for (let j = 0; j < columns; j++) {
            end.x += hStep;
            drawRectangle(start, end);
            console.log("La i=" + i + " si j=" + j + " start = " + start.x + " "+ start.y + " end = " + end.x + " "+ end.y);
            start.x += hStep;
        }
        start.y += vStep;
        end.x = 0;
        start.x = 0;
    }
}
function drowFigurin(figPos) {
    context.beginPath();
    context.arc(figPos.x, figPos.y, radius, 0, 180);
    context.fillStyle = 'green';
    context.fill();
    context.stroke();
}
drowFigurin(figPos);   
function move(direction) {
    context.clearRect(xPos - 41, yPos - 41, xPos + 41, yPos + 41);
    console.log("Clear coordinates " + (xPos - 41) + " " + (yPos - 41) + " " + (xPos + 41) + " " + (yPos + 41));
    circle.beginPath();
    yPos += 100;
    console.log(yPos);
    circle.arc(xPos, yPos, 40, 0, 180);
    circle.lineWidth = 1;
    circle.fillStyle = 'green';
    circle.fill();
    circle.stroke();
}
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

