﻿
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
function drawRectangle(start, end,thickness) {
    context.beginPath();
    context.rect(start.x, start.y, end.x, end.y);
    context.lineWidth = thickness;
    context.strokeStyle = 'gray';
    context.stroke();
}


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
