import axios from 'axios';
import  {Producer} from '../types/producer';

const server = 'http://localhost:4000';

const ProducerServer = axios.create({
    baseURL: server,
})


export const getProducer = async (): Promise<Producer[]> => {
    const response = await ProducerServer.get<Producer[]>('/producer');
    return response.data;
}
export const getProducerByEmail = async (email: string): Promise<Producer | null> => {
    const response = await ProducerServer.get<Producer>(`/producer/${email}`);
    return response.data; 
}
export const createProducer = async (producer: Producer): Promise<Producer> => {
    const response = await ProducerServer.post('/producer', producer);
    return response.data;
}
export const updateProducer = async (email: string,newProducer:Producer): Promise<Producer> => {
    const response = await ProducerServer.put(`/producer/${email}`,newProducer);
    return response.data;
}