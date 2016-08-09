jest.unmock("../mainpage");

import Input from "../mainpage";
import React from "react";
import {shallow} from "enzyme";

describe('sum', () => {
  it('adds 3 + 2 to equal 5', () => {
    const sum = require('../sum');
    expect(sum(3, 2)).toBe(5);
    });
  it('adds 3 + 3 not equal 5', () => {
    const sum = require('../sum');
    expect(sum(3,3)).not.toBe(5);
    });
});