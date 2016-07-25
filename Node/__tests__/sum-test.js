'use strict';

jest.unmock('../sum');

describe('sum', () => {
  it('adds 3 + 2 to equal 3', () => {
    const sum = require('../sum');
    expect(sum(3, 2)).toBe(5);
  });
});