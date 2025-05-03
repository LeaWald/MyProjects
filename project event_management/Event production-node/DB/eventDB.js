import mongoose from 'mongoose'
const { Schema, model } = mongoose;
mongoose.connect('mongodb://localhost:27017/event')
.then(() => console.log('Connected to MongoDB'))
.catch(err => console.error('Could not connect to MongoDB:', err));


const eventSchema = new Schema({
    name:String,
    description:String,
    producerEmail:String
  });

  const Event = model('Event', eventSchema);
  export default Event;