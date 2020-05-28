import axios from 'axios'

// create gateway url
var baseAddress = window.location.origin;
var gateway_address = process.env.NODE_ENV == 'development' ?
    '//localhost:57800' :
    `//api_gateway.${window.location.host}`;
console.log('gateway url: ' + gateway_address);

export const CreateHttpService = serviceName => {
    return axios.create({
        baseURL: `${gateway_address}/${serviceName}/`,
    });
};