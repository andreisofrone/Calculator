import { createSlice, createAction } from "@reduxjs/toolkit";
import { OPERATION } from "./utils";

const sliceName = "calculator";

export const calculatorSlice = createSlice({
	name: sliceName,
	initialState: {
		result: 0,
		firstNumber: 0,
		secondNumber: 0,
		operation: OPERATION.SUM,
	},
	reducers: {
		setResult: (state, action) => {
			state.result = action.payload;
		},
		setFirstNumber: (state, action) => {
			state.firstNumber = action.payload;
		},
		setSecondNumber: (state, action) => {
			state.secondNumber = action.payload;
		},
		setOperation: (state, action) => {
			state.operation = action.payload;
		},
	},
});

export const sum = createAction(`${sliceName}/sum`);
export const divide = createAction(`${sliceName}/divide`);
export const subtract = createAction(`${sliceName}/subtract`);
export const multiply = createAction(`${sliceName}/multiply`);
export default calculatorSlice.reducer;
export const { actions } = calculatorSlice;
