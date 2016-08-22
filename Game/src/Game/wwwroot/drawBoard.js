
var canvas = document.getElementById('myCanvas');
var context = canvas.getContext('2d');
let hLength = 300;
let vLength = 200;
let rows = 19;
let columns = 15;
let hStep = hLength / columns;
let vStep = vLength / rows;
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
            start.x += hStep;
        }
        start.y += vStep;
        end.x = 0;
        start.x = 0;
    }
    drowFigurin(figPos);
}
function drowFigurin(figPos) {
    context.beginPath();
    context.arc(figPos.x, figPos.y, radius, 0, 180);
    context.fillStyle = 'green';
    context.fill();
    context.stroke();
}
function move(direction) {
    context.clearRect(figPos.x-radius, figPos.y-radius, figPos.x+radius, figPos.y+radius);
    if (direction == "d" && figPos.y + vStep < vLength) {
        figPos.y += vStep;
    }
    if (direction == "u" && 0 < figPos.y - vStep) {
        figPos.y -= vStep;
    }
    if (direction == "r" && figPos.x + hStep < hLength) {
        figPos.x += hStep;
    }
    if (direction == "l" && 0 < figPos.x - hStep) {
        figPos.x -= hStep;
    }
    context.clearRect(0, 0, canvas.width, canvas.height);
    drawCanvas();
}