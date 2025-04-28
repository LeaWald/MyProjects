import express from 'express';
const router = express.Router();
import Event from '../DB/eventDB.js';

router.get('/event', async (req, res) => {
    console.log("Received GET request for /event");
    const events = await Event.find();
    res.send(events);
});


router.get('/event/:id', async (req, res) => {
    const event = await Event.findById(req.params.id).exec();
    console.log(event);
    if (event)
        res.send(event)
    else
        res.status(400).send('אין אירוע כזה')
});

router.post('/event', async (req, res) => {
    try {
        const addEvent = req.body;
        const event = await Event.create({
            name: addEvent.name,
            description: addEvent.description,
            producerEmail: addEvent.producerEmail,
        });
        console.log(event);
        res.status(201).send(event);
    } catch (error) {
        console.error(error);
        res.status(500).send('Error creating event');
    }
});


router.put('/event/:id', async (req, res) => {
    try {
        const updateEvent = await Event.findByIdAndUpdate(req.params.id, req.body, { new: true });
        if (!updateEvent)
            res.status(404).send('event not found');
        res.send(updateEvent);
    }
    catch (error) {
        res.status(500).send(error.message);
    }
});

router.delete('/event/:id', async (req, res) => {
    try {
        const deleteEvent = await Event.findByIdAndDelete(req.params.id);
        if (!deleteEvent) {
            return res.status(404).send('event not found');
        }
        res.status(200).send(deleteEvent); 
    } catch (error) {
        console.error("Error deleting event:", error);
        res.status(500).send(error.message);
    }
});

export default router;