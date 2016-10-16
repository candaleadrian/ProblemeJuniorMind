
var canvas = document.getElementById('myCanvas');
var context = canvas.getContext('2d');
context.translate(120, 0);
context.scale(0.8, 0.55);
context.rotate(Math.PI / 4);

const board = function (width, height, thickness) {
    const start = { x: thickness / 2, y: thickness / 2 };
    const end = { x: width - thickness, y: height - thickness };
    drawRectangle(start, end, thickness);
}
function drawRectangle(startT, endT,thicknessT) {
    context.beginPath();
    context.rect(startT.x, startT.y, endT.x, endT.y);
    context.lineWidth = thicknessT;
    context.strokeStyle = 'gray';
    context.stroke();
}


let hLength = 300;
let vLength = 200;
let rows = 2;
let columns = 3;
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
    for (let i = 0; i < rows; i++) {
        end.y = vStep;
        for (let j = 0; j < columns; j++) {
            end.x = hStep;
            drawRectangle(start, end, 1);
            start.x += hStep;
        }
        start.y += vStep;
        end.x = 0;
        start.x = 0;
    }
    drowFigurin(figPos);
    board(hLength, vLength, 3);
}
function drowFigurin(figPos) {
    context.beginPath();
    context.arc(figPos.x, figPos.y, radius, 0, 180);
    context.fillStyle = 'green';
    context.fill();
    context.stroke();
}
function move(direction) {
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
