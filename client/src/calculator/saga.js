import { call, put, takeLatest } from "redux-saga/effects";
import * as apiService from "../services/base-service";
import * as actionCreator from "./slice";

function* sum(action) {
	try {
		let result = yield call(apiService.sum, action.payload);
		yield put(actionCreator.actions.setResult(result.data));
	} catch (e) {}
}

function* divide(action) {
	try {
		let result = yield call(apiService.divide, action.payload);
		yield put(actionCreator.actions.setResult(result.data));
	} catch (e) {}
}

function* multiply(action) {
	try {
		let result = yield call(apiService.multiply, action.payload);
		yield put(actionCreator.actions.setResult(result.data));
	} catch (e) {}
}

function* subtract(action) {
	try {
		let result = yield call(apiService.subtract, action.payload);
		yield put(actionCreator.actions.setResult(result.data));
	} catch (e) {}
}

export default function* rootSaga() {
	yield takeLatest(actionCreator.sum, sum);
	yield takeLatest(actionCreator.divide, divide);
	yield takeLatest(actionCreator.multiply, multiply);
	yield takeLatest(actionCreator.subtract, subtract);
}
