async function getSpecialistInfo(specialistId) {
    try {
        const response = await fetch(`http://specialists/${specialistId}`);
        if (response.ok) {
            const data = await response.json();
            return data;
        } else {
            throw new Error('Specialist not found');
        }
    } catch (error) {
        console.error(error);
        return null;
    }
}
