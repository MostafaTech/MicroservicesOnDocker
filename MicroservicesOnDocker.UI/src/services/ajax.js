import axios from 'axios'

var baseAddress = window.location.origin;
if (baseAddress.lastIndexOf(':') > 5)
    baseAddress = baseAddress.substr(0, baseAddress.lastIndexOf(':'))

export const CreateHttpService = port => {
    return axios.create({
        baseURL: `${baseAddress}:${String(port)}/api/`,
    });
};