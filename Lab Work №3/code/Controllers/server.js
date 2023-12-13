const express = require('express');
const app = express();
const PORT = process.env.PORT || 3000;


app.get('/specialists/:specialistId', (req, res) => {
    const specialistId = req.params.specialistId;
    // Логика для получения данных о специалисте из базы данных
    const specialistData = queryDatabaseForSpecialist(specialistId);
    if (specialistData) {
        res.status(200).json(specialistData);
    } else {
        res.status(404).json({ error: 'Specialist not found' });
    }
});

function queryDatabaseForSpecialist(specialistId) {
    const result = db.query("SELECT * FROM service_specialist WHERE id_specialist = ?", [specialistId]);
    return result.length > 0 ? result[0] : null;
    return null; // Временная заглушка для примера
}

app.listen(PORT, () => {
    console.log(`Server is running on port ${PORT}`);
});

