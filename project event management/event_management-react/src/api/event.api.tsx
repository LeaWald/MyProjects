import axios from 'axios';
import  {Event} from '../types/event';

const server = 'http://localhost:4000';

const EventServer = axios.create({
    baseURL: server,
})


export const getEvent = async (): Promise<Event[]> => {
    const response = await EventServer.get<Event[]>('/event');
    return response.data;
}

export const getEventById = async (id:string | undefined): Promise<Event> => {
    const response = await EventServer.get<Event>(`/event/${id}`);
    return response.data;
}

export const createEvent = async (event: Event): Promise<Event> => {
    const response = await EventServer.post('/event', event);
    return response.data;
}

export const removeEvent = async (id:string): Promise<Event> => {
    const response = await EventServer.delete(`/event/${id}`);
    return response.data;
}
export const upDateEvent = async (id:string,newEvent:Event): Promise<Event> => {
    const response = await EventServer.put(`/event/${id}`,newEvent);
    return response.data;
}
