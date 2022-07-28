import { configureStore } from "@reduxjs/toolkit";
import createSagaMiddleware from "redux-saga";
import saga from "./calculator/saga";
import { calculatorSlice } from "./calculator/slice";

let sagaMiddleware = createSagaMiddleware();
const middleware = getDefaultMiddleware => getDefaultMiddleware().concat(sagaMiddleware);

const store = configureStore({
	reducer: {
		calculator: calculatorSlice.reducer,
	},
	middleware,
});

sagaMiddleware.run(saga);

export default store;
