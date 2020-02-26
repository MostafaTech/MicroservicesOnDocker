import axios from 'axios'

var baseAddress = window.location.origin;
if (baseAddress.lastIndexOf(':') > 5)
    baseAddress = baseAddress.substr(0, baseAddress.lastIndexOf(':'))

export const CreateHttpService = serviceName => {
    var apiGatewayPort = process.env.NODE_ENV == 'development' ? '57800' : '5000';
    return axios.create({
        baseURL: `${baseAddress}:${apiGatewayPort}/${serviceName}/`,
    });
};