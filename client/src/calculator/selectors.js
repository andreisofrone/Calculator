import { createSelector } from "reselect";

const resultSelector = state => state.calculator.result;
export const selectResult = createSelector([resultSelector], result => result);

const firstNumberSelector = state => state.calculator.firstNumber;
export const selectFirstNumber = createSelector([firstNumberSelector], firstNumber => firstNumber);

const secondNumberSelector = state => state.calculator.secondNumber;
export const selectSecondNumber = createSelector([secondNumberSelector], secondNumber => secondNumber);

const operationSelector = state => state.calculator.operation;
export const selectOperation = createSelector([operationSelector], operation => operation);
