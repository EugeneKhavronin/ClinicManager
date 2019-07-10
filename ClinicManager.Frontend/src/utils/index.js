import axios from 'axios';
import { URL } from '../constants';

export const getClinics = axios.get(`${URL}/api/clinic`);

export const createClinics = values => axios.post(`${URL}/api/clinic`, values);

export const removeClinics = guid =>
  axios.delete(`${URL}/api/clinic?guid=${guid}`);

export const getFile = guid => `${URL}/api/picture/${guid}`;
