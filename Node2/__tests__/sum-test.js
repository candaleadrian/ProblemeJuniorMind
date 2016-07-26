jest.unmock("../sum");

import Input from "../sum";
import React from "react";
import {shallow} from "enzyme";

describe('sum', () => {
  it('adds 3 + 2 to equal 3', () => {
    const sum = require('../sum');
    expect(sum(3, 2)).toBe(5);
    });
});