import React, { useEffect } from "react";
import Grid from "@mui/material/Grid";
import "../App.css";
import { useDispatch, useSelector } from "react-redux";
import * as selectors from "./selectors";
import * as actionCreator from "./slice";
import FormControlSelect from "../common-components/form-control-select";
import { OPERATION } from "./utils";
import TextField from "@mui/material/TextField";
import Button from "@mui/material/Button";
import { sum, divide, multiply, subtract } from "./slice";

export default function App() {
	const dispatch = useDispatch();
	const result = useSelector(selectors.selectResult);
	const firstNumber = useSelector(selectors.selectFirstNumber);
	const secondNumber = useSelector(selectors.selectSecondNumber);
	const operation = useSelector(selectors.selectOperation);

	const handleOnChangeFirstNumber = event => dispatch(actionCreator.actions.setFirstNumber(event.target.value));
	const handleOnChangeSecondNumber = event => dispatch(actionCreator.actions.setSecondNumber(event.target.value));
	const handleOnChangeOperator = event => dispatch(actionCreator.actions.setOperation(event.target.value));

	const handleCalculate = () => {
		var payload = {
			firstNumber: firstNumber,
			secondNumber: secondNumber,
		};

		switch (operation) {
			case OPERATION.DIVIDE:
				dispatch(divide(payload));
				break;
			case OPERATION.MULTIPLY:
				dispatch(multiply(payload));
				break;
			case OPERATION.SUM:
				dispatch(sum(payload));
				break;
			case OPERATION.SUBTRACT:
				dispatch(subtract(payload));
				break;
			default:
				break;
		}
	};

	return (
		<>
			<Grid
				container
				xs={12}
				spacing={1}
				sx={{
					padding: "100px",
					display: "flex",
					justifyContent: "center",
					alignItems: "center",
				}}>
				<Grid item xs={1}>
					<TextField key="first-number" variant="outlined" type="number" onChange={handleOnChangeFirstNumber} />
				</Grid>
				<Grid item xs={1}>
					<FormControlSelect
						id="operator"
						key="operator-key"
						menuItems={[
							{ name: "+", value: OPERATION.SUM },
							{ name: "-", value: OPERATION.SUBTRACT },
							{ name: "/", value: OPERATION.DIVIDE },
							{ name: "*", value: OPERATION.MULTIPLY },
						]}
						value={operation}
						label="Operator"
						onChange={handleOnChangeOperator}
					/>
				</Grid>
				<Grid item xs={1}>
					<TextField key="second-number" variant="outlined" type="number" onChange={handleOnChangeSecondNumber} />
				</Grid>
				<Grid
					sx={{
						textAlign: "center",
					}}>
					=
				</Grid>
				<Grid item xs={2}>
					<TextField key="result" label="Result" variant="outlined" value={result} />
				</Grid>
				<Grid item xs={2}>
					<Button variant="contained" onClick={handleCalculate}>
						Calculate
					</Button>
				</Grid>
			</Grid>
		</>
	);
}
