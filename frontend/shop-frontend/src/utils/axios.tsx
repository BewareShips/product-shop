import axios from 'axios';

const apiClient = axios.create({
  baseURL: 'https://api.example.com', 
});

apiClient.interceptors.response.use(
  response => response,
  error => {
    if (error.response) {
     
      console.error('Response error:', error.response);
    } else if (error.request) {
     
      console.error('Request error:', error.request);
    } else {
   
      console.error('Error', error.message);
    }
    return Promise.reject(error);
  }
);

export default apiClient;