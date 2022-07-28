import axiosInstance from "./axios-instance";

export const sum = payload => {
	return axiosInstance.post(`/calculator/sum`, payload);
};

export const divide = payload => {
	return axiosInstance.post(`/calculator/divide`, payload);
};

export const multiply = payload => {
	return axiosInstance.post(`/calculator/multiply`, payload);
};

export const subtract = payload => {
	return axiosInstance.post(`/calculator/subtract`, payload);
};
