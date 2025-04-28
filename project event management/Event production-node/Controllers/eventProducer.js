import express from 'express';
const router = express.Router();
import Producer from '../DB/eventProducerDB.js';


router.get('/producer', async (req, res) => {
    console.log("Received GET request for /producer");
    const producer = await Producer.find();
    res.send(producer);
});
router.get('/producer/:email', async(req, res)=>{
    const producer = await Producer.findOne({email:req.params.email});
    console.log(producer);
    if (producer)
        res.send(producer)
    else
        res.status(400).send('אין מפיק כזה')
});

router.post('/producer', async(req, res) => {
    try {
        const addProducer = req.body;
        const producer = await Producer.create({
            name: addProducer.name,
            email: addProducer.email,
            phone: addProducer.phone,
            description: addProducer.description
        });
        console.log(producer);
        res.status(201).send(producer);
    } catch (error) {
        console.error(error);
        if (error.code === 11000) { 
            res.status(400).send('שגיאה: האימייל כבר קיים במערכת.');
        } else {
            res.status(500).send('שגיאה בעת יצירת המפיק');
        }
    }
});

router.put('/producer/:email',async(req, res)=>{
    try {
        const updateProduct = await Producer.findOneAndUpdate({email:req.params.email}, req.body, { new: true });
        if (!updateProduct)
            res.status(404).send('producer not found');
        res.send(updateProduct);
    }
    catch (error) {
        res.status(500).send(error.message);
    }
});

export default router;