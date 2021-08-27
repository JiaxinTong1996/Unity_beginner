{
    "@type": "MessageCard",
    "@context": "http://schema.org/extensions",
    "themeColor": "0076D7",
    "summary": "Larry Bryant created a new task",
    "sections": [{
        "activityTitle": "Larry Bryant created a new task",
        "activitySubtitle": "On Project Tango",
        "activityImage": "https://teamsnodesample.azurewebsites.net/static/img/image5.png",
        "facts": [{
            "name": "Assigned to",
            "value": "Unassigned"
        }, {
            "name": "Due date",
            "value": "Mon May 01 2017 17:07:18 GMT-0700 (Pacific Daylight Time)"
        }, {
            "name": "Status",
            "value": "Not started"
        }],
        "markdown": true
    }],
    "potentialAction": [{
        "@type": "ActionCard",
        "name": "Add a comment",
        "inputs": [{
            "@type": "TextInput",
            "id": "comment",
            "isMultiline": false,
            "title": "Add a comment here for this task"
        }],
        "actions": [{
            "@type": "HttpPOST",
            "name": "Add comment",
            "target": "https://northeastern.webhook.office.com/webhookb2/fa776995-e267-410b-9e20-d9f245819016@a8eec281-aaa3-4dae-ac9b-9a398b9215e7/IncomingWebhook/f54b911147cb47d29de881d6334bd778/6e21e977-f8e7-481a-a5a6-b9439b39b1b0"
        }]
    }, {
        "@type": "ActionCard",
        "name": "Set due date",
        "inputs": [{
            "@type": "DateInput",
            "id": "dueDate",
            "title": "Enter a due date for this task"
        }],
        "actions": [{
            "@type": "HttpPOST",
            "name": "Save",
            "target": "https://northeastern.webhook.office.com/webhookb2/fa776995-e267-410b-9e20-d9f245819016@a8eec281-aaa3-4dae-ac9b-9a398b9215e7/IncomingWebhook/f54b911147cb47d29de881d6334bd778/6e21e977-f8e7-481a-a5a6-b9439b39b1b0"
        }]
    }, {
        "@type": "OpenUri",
        "name": "Learn More",
        "targets": [{
            "os": "default",
            "uri": "https://northeastern.webhook.office.com/webhookb2/fa776995-e267-410b-9e20-d9f245819016@a8eec281-aaa3-4dae-ac9b-9a398b9215e7/IncomingWebhook/f54b911147cb47d29de881d6334bd778/6e21e977-f8e7-481a-a5a6-b9439b39b1b0"
        }]
    }, {
        "@type": "ActionCard",
        "name": "Change status",
        "inputs": [{
            "@type": "MultichoiceInput",
            "id": "list",
            "title": "Select a status",
            "isMultiSelect": "false",
            "choices": [{
                "display": "In Progress",
                "value": "1"
            }, {
                "display": "Active",
                "value": "2"
            }, {
                "display": "Closed",
                "value": "3"
            }]
        }],
        "actions": [{
            "@type": "HttpPOST",
            "name": "Save",
            "target": "https://northeastern.webhook.office.com/webhookb2/fa776995-e267-410b-9e20-d9f245819016@a8eec281-aaa3-4dae-ac9b-9a398b9215e7/IncomingWebhook/f54b911147cb47d29de881d6334bd778/6e21e977-f8e7-481a-a5a6-b9439b39b1b0"
        }]
    }]
}